import tkinter as tk

def check_tkinter():
    root = tk.Tk()
    root.title("Tkinter Check")
    label = tk.Label(root, text="Tkinter is working!")
    label.pack()
    root.mainloop()

if __name__ == "__main__":
    check_tkinter()
