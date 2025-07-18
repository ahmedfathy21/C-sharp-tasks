# you have to access using: ssh -X <name>@<IP>

import tkinter as gui
import RPi.GPIO as GPIO

LED = 22

GPIO.setwarnings(False)
GPIO.setmode(GPIO.BCM)
GPIO.setup(LED, GPIO.OUT)

state = 0

def LED_Toggle():
    global state
    state ^= 1 
    print("pressed")
    GPIO.output(LED, state)


# main waindow
main_window = gui.Tk()
main_window.title("Control Led")
main_window.geometry("400x200+200+100")
main_window.resizable(False, False)
main_window.configure(background="white")

# widgets
buttontoggle = gui.Button(main_window, text="LED Toggle", command=LED_Toggle, bg="blue", fg="white")
# Button place on screen
buttontoggle.place(x=150, y=75)

main_window.mainloop()