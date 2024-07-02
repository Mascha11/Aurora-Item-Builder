from PyQt5.QtWidgets import QApplication, QTextEdit, QVBoxLayout, QPushButton, QWidget, QFileDialog
from PyQt5.QtGui import QTextCursor, QTextCharFormat, QFont

def apply_format(tag):
    cursor = text.textCursor()
    format = QTextCharFormat()

    if tag == "bold":
        if cursor.charFormat().fontWeight() == QFont.Bold:
            format.setFontWeight(QFont.Normal)
        else:
            format.setFontWeight(QFont.Bold)
    elif tag == "italic":
        format.setFontItalic(not cursor.charFormat().fontItalic())
    
    cursor.mergeCharFormat(format)
    text.mergeCurrentCharFormat(format)

def save_to_file():
    file_path, _ = QFileDialog.getSaveFileName(None, "Save File", "", "Text files (*.txt);;HTML files (*.html)")
    if file_path:
        with open(file_path, "w") as file:
            file.write(text.toHtml())

app = QApplication([])

window = QWidget()
layout = QVBoxLayout()

text = QTextEdit()
layout.addWidget(text)

bold_btn = QPushButton("Bold")
bold_btn.clicked.connect(lambda: apply_format("bold"))
layout.addWidget(bold_btn)

italic_btn = QPushButton("Italic")
italic_btn.clicked.connect(lambda: apply_format("italic"))
layout.addWidget(italic_btn)

# Button to save content to file
save_btn = QPushButton("Save")
save_btn.clicked.connect(save_to_file)
layout.addWidget(save_btn)

window.setLayout(layout)
window.show()

app.exec_()
