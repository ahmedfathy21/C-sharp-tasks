#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <unistd.h>
#include <string.h>
#include <stdio.h>

#define PATH_EXPORT         "/sys/class/gpio/export"
#define PATH_UNEXPORT       "/sys/class/gpio/unexport" // echo 534 > /sys/class/gpio/unexport
#define PATH_DIRECTION      "/sys/class/gpio/gpio534/direction"
#define PATH_VALUE          "/sys/class/gpio/gpio534/value"
#define LED_PIN             "534"       // 534 -> GPIO22 "run: cat /sys/kernel/debug/gpio" to see gpio numbers
#define LED_DIRECTION       "out"

void direction_init()
{
    int fd= open(PATH_DIRECTION, O_WRONLY);
    if( fd ==-1 )
    {
    printf("file  [Direction] cannot open ");
    return ;
    }

    write( fd, LED_DIRECTION, strlen(LED_DIRECTION));

    close(fd);
}

void export_init()
{
    int fd= open(PATH_EXPORT, O_WRONLY);
    if( fd ==-1 )
    {
    printf("file  [Export] cannot open ");
    return ;
    }

    write( fd, LED_PIN, strlen(LED_PIN));

    close(fd);
}


//main
int main()
{
    export_init();
    sleep(1);
    direction_init();

    int fd= open(PATH_VALUE, O_WRONLY);
    if( fd ==-1 )
    {
        printf("file  [Export] cannot open ");
        return -1;
    }
    while(1)
    {
            
        write( fd, "1", strlen("1"));
        sleep(1);
        write( fd, "0", strlen("0"));
        sleep(1);
        
    }
    close(fd);

    return 0;
}