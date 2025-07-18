import os
import sys
import RPi.GPIO as GPIO
from time import sleep

PIN_NUMBER = 22

# Set the GPIO mode to BCM (Broadcom SOC channel numbering)
GPIO.setmode(GPIO.BCM)

GPIO.setup(PIN_NUMBER, GPIO.OUT)

try:
    while True:
        state = input("Enter state (on<1>/off<0>) or 'exit' to quit: ").strip().lower()

        # If the input is 'on' or '1', set the pin to HIGH
        if state == "on" or state == "1":
            GPIO.output(PIN_NUMBER, GPIO.HIGH)

        # If the input is 'off' or '0', set the pin to LOW
        elif state == "off" or state == "0":
            GPIO.output(PIN_NUMBER, GPIO.LOW)

        elif state == "exit":
            break
        else:
            print("Invalid input. Please enter 'on', 'off', or 'exit'.")

# Handle a keyboard interrupt (e.g., Ctrl+C)
except KeyboardInterrupt:
    print("\nProgram interrupted by user.")

# Ensure the GPIO settings are reset to avoid conflicts with future programs
finally:
    GPIO.cleanup()
    print("GPIO cleanup done. Exiting safely.")
