import RPi.GPIO as GPIO
from time import sleep
import signal

PWM_PIN = 12

GPIO.setmode(GPIO.BCM)
GPIO.setup(PWM_PIN, GPIO.OUT)

pwm = GPIO.PWM(PWM_PIN, 50)  # 50 Hz frequency
pwm.start(0)

def set_angle(angle):
    duty_cycle = angle / 18 + 2
    pwm.ChangeDutyCycle(duty_cycle)
    sleep(0.5)
    pwm.ChangeDutyCycle(0)

def signal_handler(signum, frame):
    print("\nCleaning up GPIO...")
    pwm.stop()
    GPIO.cleanup()
    exit()

# Set up signal handlers
signal.signal(signal.SIGINT, signal_handler)  # Catch Ctrl+C

while True:
    for angle in range(0,181,5):
        set_angle(angle)
        sleep(2)