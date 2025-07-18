// Compile & link & generate output file
//   -> gcc -o <output file name> <file name> -lgpiod
//   -> gcc -o cBut.out cButton.c -lgpiod
// Run
//   -> ./<output file name>
//   -> ./cBut.out

#include <gpiod.h>          
#include <stdio.h>          
#include <unistd.h>
#include <signal.h>

#define PIN_NUMBER      22
#define CONSUMER_NAME   "Button"

struct gpiod_chip *chip = NULL;
struct gpiod_line *line = NULL;

void cleanup()
{
    if(line)
        gpiod_line_release(line);
    if(chip)
        gpiod_chip_close(chip);
    printf("\nGPIO cleanup done. Exiting safely.\n");
    exit(EXIT_SUCCESS);
}

int main()
{
    int state = 0;

    signal(SIGINT, cleanup);

    chip = gpiod_chip_open_by_name("gpiochip0");
    if(!chip)
    {
        perror("Chip open Failure");
        return EXIT_FAILURE;
    }

    line = gpiod_chip_get_line(chip, PIN_NUMBER);
    if(!line)
    {
        perror("Get line Failure");
        gpiod_chip_close(chip);
        return EXIT_FAILURE;
    }

    if(0 > gpiod_line_request_input(line, CONSUMER_NAME))
    {
        perror("Request line output Failure");
        cleanup();
    }

    while(true)
    {
        state = gpiod_line_get_value(line);
        if(state){
            printf("Pressed\n");
            while(gpiod_line_get_value(line));
        }
        usleep(5000);           // 5 ms
    }

    return EXIT_SUCCESS;
}