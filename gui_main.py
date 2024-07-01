import tkinter as tk
from tkinter import messagebox

def save_input():
    user_input = entry.get()
    file_name = file_entry.get() or "output.txt"
    
    with open(file_name, "a") as file:
        file.write(user_input + "\n")
    
    messagebox.showinfo("Info", f"Your input has been saved to {file_name}")
    entry.delete(0, tk.END)

def clear_input():
    entry.delete(0, tk.END)

def exit_program():
    root.quit()

# Create the main window
root = tk.Tk()
root.title("Text Saver")

# Create a label for text input
label = tk.Label(root, text="Enter some text:")
label.pack(pady=10)

# Create an entry widget for text input
entry = tk.Entry(root, width=50)
entry.pack(pady=10)

# Create a label for file name input
file_label = tk.Label(root, text="Enter file name:")
file_label.pack(pady=10)

# Create an entry widget for file name input
file_entry = tk.Entry(root, width=50)
file_entry.pack(pady=10)

# Create a save button
save_button = tk.Button(root, text="Save", command=save_input)
save_button.pack(pady=10)

# Create a clear button
clear_button = tk.Button(root, text="Clear", command=clear_input)
clear_button.pack(pady=5)

# Create an exit button
exit_button = tk.Button(root, text="Exit", command=exit_program)
exit_button.pack(pady=5)

# Run the application
root.mainloop()
