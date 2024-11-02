import sys

def dataCleanup(text):
    if "\r" in text:
        text = text.replace("\r", "")
    if "\n" in text:
        text = text.replace("\n", " ")
    text = text.split(", ")
    text = " ".join(text).split()
    return text

def replaceComma(i):
    return i.replace(",", "")

def findWords(keywords, text):
    text = dataCleanup(text)
    keywords = dataCleanup(keywords)
    
    counts = [0] * len(keywords)

    for each in range(0, len(text)):
        for i in range(0, len(keywords)):
            if keywords[i] == text[each]:
                counts[i] += 1

    #For debugging purposes
    #print("Text = ", text)
    #print("Keywords = ", keywords)
    #print("Counts = ", counts, "\n")

    #Messgage that's returned to the form
    for i in range(0, len(keywords)):
        print("The keyword", f"\'{keywords[i]}\'", "appears", counts[i], "time(s).", "\n")



findWords(sys.argv[1], sys.argv[2])

