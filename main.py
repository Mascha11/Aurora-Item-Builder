# main.py

def main():
    # Get user input
    user_input = input("Enter some text: ")

    # Define the file name
    file_name = "output.txt"

    # Write the input to the file
    with open(file_name, "a") as file:
        file.write(user_input + "\n")

    print(f"Your input has been saved to {file_name}")

if __name__ == "__main__":
    main()
