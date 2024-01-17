#написать программу для решения квадратного уравнения a*x**2-b*x-c=0
from math import *


vastus=input("Las lähendmaе ruutvõrrand?").lower()
if vastus=="jah":
    print("Ruutvõrrandi lähendamine:")
    try:
        #a,b,c=map(float,input("a,b,c:")).splite(",")
        a=float(input("a: "))
        b=float(input("b: "))
        c=float(input("c: "))
        D=b**2-4*a*c
        if D>0:
            x1=(-b+sqrt(D))/2*a 
            x2=(-b-sqrt(D))/2*a 
            print("2 lahendust 1:{0:.2f},2:{0:.2f} ".format(x1,x2))
        elif D==0:
            x1=(-b/2*a)
            print("1 Lahendus: {1:.2f} ".format(x1))
        else:
            print("Lahendused puudavad")
    except :
        print("Viga andmetüübiga")
else:
    print("Head aega!")

   #1
n=input("Sisestage number: ")
if n==0:
    print("null")
elif int>0:
    if n % 2 == 0:
        print("Arv on paaris.")
    else:
        print("Arv on paaritu")
elif n<0:
    print("Arv on negatiivne")
else:
    print("Arv on null")

    #2
from math import *
a,b,c=map(float,input("a,b,c:").split())
if a>0 and b>0 and c>0:
    if a+b+c==180:
        print("Kolmnurk")
        if a==b==c:
            print("Võrkülgne")
        elif a==b or b==c or a==c:
            print("võrkhaarne")
        else:
            print("erikülgne")
    else:
        print("Nurgad")
else:
    print("<0")

    #3
vastus=input("Kas tahad 1-7 numbrist saada päeva nimetus?")
if vastus.lower()=="jah":
    try:
        nr=int(input("Päeva number: "))
        if nr==1:
            p="eesmaspäev"
        elif nr==2:
            p="teisipäev"
        elif nr==3:
            p="kolmapäev"
        elif nr==4:
            p="neljapäev"
        elif nr==5:
            p="reede"
        elif nr==6:
            p="laupäev"
        elif nr==7:
            p="pühapäev"
        else:
            p="on vaja 1-7"
        print(p)
    