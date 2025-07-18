#!/bin/bash

# Function to clean up GPIO before exiting
cleanup() {
    echo "Reseting GPIO and exiting..."
    gpioset --mode=exit gpiochip0 22=0
    exit 0
}

# Trap SIGINT (Ctrl+C) and call the cleanup function
trap cleanup SIGINT

gpioset --mode=exit gpiochip0 22=1

# Toggle GPIO22
while true; do
    gpioset --mode=exit gpiochip0 22=1
    sleep 1
    gpioset --mode=exit gpiochip0 22=0
    sleep 1
done

# Why Use --mode=exit?
#
#    Temporary State Setting: If you need to briefly set a pin and ensure it's reset or available for other processes afterward.
#    Safety: Prevents the line from being locked by the command indefinitely, which could otherwise block other applications from accessing the GPIO line.
#    Non-Persistent Control: Ideal for scripts or quick commands where long-term control isn't required.

#--mode=exit (default):
#    Holds the line while the command is running and releases it when the command exits.

#--mode=wait:
#    Keeps the line set until a specified condition occurs, such as an event or a timeout.

#--mode=signal:
#    Holds the line until the process receives a termination signal (e.g., SIGTERM or SIGINT).

#--mode=keep:
#    Holds the line even after the command exits. This mode requires manual cleanup to release the GPIO line later.