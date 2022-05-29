# Metaphone
English version:

### DESCRIPTION OF THE ALGORITHM 
Metaphone is an algorithm that encodes strings into a phonetic form where two strings 
that sounds similar gets a similar Metaphone encoding. 
The encoding is done by applying a series of transformations to the string. These are 
slightly different and should be applied in the correct sequence. 
The Metaphone algorithm deals only with letters from the English alphabet (a-z).<br /><br />
 
 
 
### THE ALGORITHM

16 consonant sounds: 
B X S K J T F H L M N P R 0 W Y

0 represents the "th" sound.


### Exceptions: 

Initial kn-, gn-, pn, ac- or wr- → drop first letter.  

Initial x- → change to "s"  

Initial wh- → change to "w"  


### Transformations: 

Vowels are kept only when they are the first letter  

B → B unless at the end of a word after "m" as in "dumb"  

C → X (sh) if -cia- or -ch- S if -ci-, -ce- or -cy- K otherwise, including -sch-  

D → J if in -dge-, -dgy- or -dgi- T otherwise  

F → F  

G → silent in -gh- and not at end or before a vowel silent in -gn- or -gned- (also see  

dge etc. above) J if before i or e or y if not double gg K otherwise  

H → silent if after vowel and no vowel follows H otherwise  

J → J  

K → silent if after "c" K otherwise  

L → L  

M → M  

N → N  

P → F if in -ph- P otherwise  

Q → K  

R → R  

S → X (sh) if before "h" or in -sio- or -sia- S otherwise  

T → X (sh) f -tia- or -tio- 0 (th) if before "h" silent if in -tch- T otherwise  

V → F  

W → silent if not followed by a vowel W if followed by a vowel  

X → KS  

Y → silent if not followed by a vowel Y if followed by a vowel  

Z → S  


### TEST DATA

These are some examples of strings (input) and what the result should be  
 
### Input                           Result  


solitude         SLTT

debunker       TBNKR

aardvark        ARTFRK

cutlass           KTLSS

metaphone    MTFN

kiss                KSS

roosevelt        RSFLT

knock             NK  

xanadu           SNT  

### A slightly different algorhithm

![Metaphone](https://user-images.githubusercontent.com/89773023/170864956-ad1be6fb-0383-44f3-ade5-6f614cb5389e.png)

