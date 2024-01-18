print("Tere! Olen sinu uus sõber -Python!")
nimi=input("Mis on sinu nimi?")
print(nimi+", oi kui ilus nimi!")
number=(int(input(nimi+"! Kas leian Sinu keha indeksi?i 0-ei, 1-jah =>")))
if number==1:
    pikkus=float(input("Pikkus= "))
    mass=float(input("mass= "))
    indeks=mass/(0.01*pikkus)**2
    print("!Sinu keha indeks on:", indeks)
if indeks<16:
    print("Tervisele ohtlik alakaal")
elif indeks>16 and indeks<19:
    print("Alakaal")
elif indeks>19 and indeks<25:
    print("Normaalkaal")
elif indeks>25 and indeks<30:
    print("Ülekaal")
elif indeks>30 and indeks<35:
    print("Rasvumine")
elif indeks>35 and indeks<40:
    print("Tugev rasvumine")
elif indeks>40:
    print("Tervisele ohtlik rasvumine")

