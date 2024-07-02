import tkinter as tk
from tkinter import messagebox, ttk

def save_input():
    name = Field1.get()
    type = Field2.get()
    source = Field3.get()
    author = Field4.get()
    user_number = number_spinbox.get()
    
    checkboxes = [chk1_var.get(), chk2_var.get(), chk3_var.get()]
    menu_choice = submenu_var.get()
    
    output = (
        f"Text: {name}\n"
        f"Number: {user_number}\n"
        f"Option: {type}\n"
        f"Checkboxes: {checkboxes}\n"
        f"Submenu Choice: {menu_choice}\n"
    )
    
    with open("output.txt", "a") as file:
        file.write(output + "\n")
    
    messagebox.showinfo("Info", "Your input has been saved to output.txt")
    #clear_input()

#def clear_input():
#    Field1.delete(0, tk.END)
#    number_spinbox.delete(0, tk.END)
#    number_spinbox.insert(0, 0)
#    Field2.set(options[0])
#    chk1_var.set(False)
#    chk2_var.set(False)
#    chk3_var.set(False)
#    submenu_var.set(submenu_options[0])
#    submenu_frame.pack_forget()

def update_submenu(*args):              #If Option 2 show submenu frame
    if Field2.get() == "Option 2":
        submenu_frame.pack(pady=10)
    else:
        submenu_frame.pack_forget()

def exit_program():
    root.quit()

# Create the main window
root = tk.Tk()
root.title("Advanced Input Form")

# Create Name Inout
tk.Label(root, text="Enter item name:").pack(pady=5)
Field1 = tk.Entry(root, width=50)
Field1.pack(pady=5)

# Create Field2 menu
options = ["Item", "Magic Item", "Weapon", "Magic Weapon"]
Field2 = tk.StringVar(value=options[0])
tk.Label(root, text="Choose a Type:").pack(pady=5)
option_menu = ttk.OptionMenu(root, Field2, options[0], *options, command=update_submenu)  #need later for category
option_menu.pack(pady=5)

# Create Source Text Field
tk.Label(root, text="Enter Source (Book).").pack(pady=5)
Field3 = tk.Entry(root, width=50)
Field3.pack(pady=5)

# Create Author Text Field
tk.Label(root, text="Enter Author").pack(pady=5)
Field4 = tk.Entry(root, width=50)
Field4.pack(pady=5)

# Create number input
tk.Label(root, text="Enter a number:").pack(pady=5)
number_spinbox = tk.Spinbox(root, from_=0, to=100, width=47)
number_spinbox.pack(pady=5)

# Create checkboxes
tk.Label(root, text="Select checkboxes:").pack(pady=5)
chk1_var = tk.BooleanVar()
chk2_var = tk.BooleanVar()
chk3_var = tk.BooleanVar()
tk.Checkbutton(root, text="Checkbox 1", variable=chk1_var).pack(pady=2)
tk.Checkbutton(root, text="Checkbox 2", variable=chk2_var).pack(pady=2)
tk.Checkbutton(root, text="Checkbox 3", variable=chk3_var).pack(pady=2)

# Create a frame for the submenu
submenu_frame = tk.Frame(root)
tk.Label(submenu_frame, text="Submenu options:").pack(pady=5)
submenu_options = ["Submenu Option 1", "Submenu Option 2", "Submenu Option 3"]
submenu_var = tk.StringVar(value=submenu_options[0])
submenu_menu = ttk.OptionMenu(submenu_frame, submenu_var, submenu_options[0], *submenu_options)
submenu_menu.pack(pady=5)

# Create save and clear buttons
tk.Button(root, text="Save", command=save_input).pack(pady=10)
#tk.Button(root, text="Clear", command=clear_input).pack(pady=5)
tk.Button(root, text="Exit", command=exit_program).pack(pady=5)

# Run the application
root.mainloop()
