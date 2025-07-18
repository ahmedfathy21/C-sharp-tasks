import RPi.GPIO as GPIO
import time

PIN_NUMBER = 22

# Setup GPIO
GPIO.setmode(GPIO.BCM)
GPIO.setup(PIN_NUMBER, GPIO.IN)

last_state = GPIO.input(PIN_NUMBER)

try:
    while True:
        current_state = GPIO.input(PIN_NUMBER)
        if current_state != last_state:
            if current_state == 1: 
                print("Pressed")
            last_state = current_state
        time.sleep(0.1)
finally:
    GPIO.cleanup()
