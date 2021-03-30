
"""
Make a function for each of the below.

You can run this script by calling either "python Week8.py" (Mac/Linux) or "py Week8.py" (Windows) from
a command line interface once you've navigated to the correct folder.

cd (change directory) 
	EX: cd Desktop/AGP_ProblemSets/Week8/ 
ls (list current directory) 

"""

# Return true if even, false if odd
def isEven(input) :

	if input % 2 == 0:

		return True

	else:

		return False


# Return the product of the input and all positive integers below it.
def factorial(input) :

	if input <= 1:
		return input

	else: 
		return input * factorial(input-1)

# Given a list of numbers, return the difference between the largest and smallest.
def widthOfList(input) :
	smallest = input[0]
	largest = input[0]

	#i = 0
	for n in input:

		#print('n = ', n)
		#print('i = ', i)

		'''
		if input[i] < smallest:
			smallest = input[i]
		if input[i] > largest:
			largest = input[i]
		'''

		if n < smallest:
			smallest = n
		if n > largest:
			largest = n

		#i+=1

	return largest - smallest

"""

Write a function that takes in a number and determines whether it's the same upside down.

6090609		True 
6996		False 		(becomes 9669)
806908		True

"""


"""
if contains 1,2,3,4,5,7, not same upside down

recursive palindrome checker but if 6 or 9 swap, 8 or 0 stay

"""
def sameUpsideDown(input) :
	'''
	remainder = 100

	while remainder > 10:
		remainder = input % 10
		if remainder == 1 || remainder == 2 || remainder == 3 || remainder == 4 || remainder == 5 || remainder == 7:
			return False


	'''
	return True


# Read the provided list of words, write to "output.txt" all words of given length that start with that letter.
def allWordsOfLength(length, startingLetter) :

	wordlist = open("wordlist.txt", "r")
	print(wordlist)

	return 0

# ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ #
# Don't edit below this line.

class bcolors:
    HEADER = '\033[95m'
    OKBLUE = '\033[94m'
    OKGREEN = '\033[92m'
    WARNING = '\033[93m'
    FAIL = '\033[91m'
    ENDC = '\033[0m'
    BOLD = '\033[1m'
    UNDERLINE = '\033[4m'

def printTest(text, color = "") :
	print (color + text + bcolors.WARNING)

check = lambda a : bcolors.OKGREEN + 'Correct ' if a else bcolors.FAIL + 'Incorrect '

printTest("\nPython Tests:", bcolors.BOLD)

printTest("Is Even Tests:", bcolors.HEADER)

printTest(check(isEven(2)) + 'for isEven returning correctly for even input.')
printTest(check(not isEven(3)) + 'for isEven returning correctly for odd input.')

printTest("\nFactorial Tests:", bcolors.HEADER)

printTest(check(factorial(4) == 24) + 'for factorial w/ input 4.')
printTest(check(factorial(8) == 40320) + 'for factorial w/ input 8.')

printTest("\nWidth of List Tests:", bcolors.HEADER)

printTest(check(widthOfList([1, 3]) == 2) + 'for width of list with two numbers.')
printTest(check(widthOfList([1, 2, 3, 4, 5]) == 4) + 'for width of list with more than two nubmers.')
printTest(check(widthOfList([1, 1, 1, 1, 1, 1]) == 0) + 'for width of list with the same number for all entries.')

printTest("\nSame Upside Down:", bcolors.HEADER)

printTest(check(sameUpsideDown(806908)) + 'for 806908.')
printTest(check(not sameUpsideDown(284392)) + 'for 284392.')
printTest(check(not sameUpsideDown(6996)) + 'for 6996.')
printTest(check(sameUpsideDown(806908)) + 'for 806908.')


printTest("\nWords of Length Test:", bcolors.HEADER)
allWordsOfLength(2, 'E')
with open('output.txt') as filehandle : 
	printTest(check(len(filehandle.readlines()) == 1) + 'found all 2 letter words starting with E.')

allWordsOfLength(3, 'A')
with open('output.txt') as filehandle : 
	printTest(check(len(filehandle.readlines()) == 7) + 'found all 3 letter words starting with A.')

allWordsOfLength(6, 'E')
with open('output.txt') as filehandle : 
	printTest(check(len(filehandle.readlines()) == 36) + 'found all 6 letter words starting with E.')