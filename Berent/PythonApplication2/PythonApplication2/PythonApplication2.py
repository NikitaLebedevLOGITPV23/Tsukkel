from optparse import Values


print("Tere! Olen sinu uus sober - Python!")
nimi =input('mis sinu nimi on? ')
print(nimi, ", oi kui ilus nimi!")
print(nimi, "! Kas leian Sinu keha indeksi?")
answer = int(input('0-ei, 1-jah => '))
if answer == 1:
    while True:
        try:
           pikkus = int(input('Mis sinu pikkus on?: '))
           mass = float(input('Mis sinu kaal on?: '))
           indeks = mass/(0.01*pikkus)**2
           print(nimi,"! Sinu keha indeks on: ", indeks)
           break
        except:
            print('Vale info, proovi uuesti!')
    if indeks < 16:
        print('Teil on Tervisele ohtlik alakaal!')