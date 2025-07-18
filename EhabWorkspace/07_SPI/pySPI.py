import spidev
import time
import RPi.GPIO as GPIO

# Set SPI bus and device
spi_bus = 0
spi_device = 0

# Set the CS pin (e.g., CE0 = GPIO8 or CE1 = GPIO7)
CS_PIN = 8

# Set up the GPIO pin for CS manually
GPIO.setmode(GPIO.BCM)
GPIO.setup(CS_PIN, GPIO.OUT)
GPIO.output(CS_PIN, GPIO.HIGH)

# Open SPI connection with mode 0
spi = spidev.SpiDev()
spi.open(spi_bus, spi_device)
spi.max_speed_hz = 50000  # Set SPI speed
spi.mode = 0  # Set SPI mode to 0 (CPOL=0, CPHA=0)

# Define the data to be sent
data_to_send = [0xFF]

try:
    while True:
        # Ask the user if they want to send data
        user_input = input("Do you want to send data? (yes/no): ").strip().lower()
        
        if user_input == "yes":
            # Pull the CS pin low to start the transaction
            GPIO.output(CS_PIN, GPIO.LOW)
            
            # Send data
            response = spi.xfer2(data_to_send)
            print(f"Sent: 0xFF, Received: 0x{response[0]:02X}")
            
            # Pull the CS pin high to end the transaction
            GPIO.output(CS_PIN, GPIO.HIGH)
            # Wait a little before the next prompt
            time.sleep(0.5)
            
        elif user_input == "no":
            print("Exiting...")
            break
        else:
            print("Invalid input. Please enter 'yes' or 'no'.")
finally:
    GPIO.cleanup()
    spi.close()
