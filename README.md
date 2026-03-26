# apbd-cw2-git-s33974
Poglądowy system klas:

Interfejs:

    Lendable

Klasy:
Część modelowa:

    (abstract)Equipment(string brand, string name) implements Lendable
        (abstract)VisualMediaEquipment(string brand, string name, int baseResWidth, int baseResHeight)
            Laptop
            Camera
            Projector

	(abstact)User(string role, string name, string surname, int allowedLeaseCount)
		Employee(string name, string surname)
		Student(string name, string surname, int index)
	
	Lease(Equipment eq, User us, DateTime startDate, DateTime deadLine, DateTime? endDate, double dailyRate)

Część serwisowa:

    Program
    Database()
    ReportPrinter(Database db)

**Opis części modelowej:**

Starałem się utworzyś wyraźną, łatwo skalowalną hierarchię dziedziczących klas. Na przykład zauważywszy, że wszystkie 3 rodzaje sprzętu przechowują informacje o swojej bazowej rozdzielczości, postanowiłem zaklasyfikować je do jednej abstrakcyjnej grupy "VisualMediaEquipment", która przechowuje te informacje. Zmniejsza to liczbę powtarzanych indywidualnych pól każdej z nie-abstrakcyjnych klas specjalnych.

Klasy abstrakcyjne leżące u podstaw: "User" oraz "Equipment" pozostają uniwersalne i można z łatwością dodawać do nich nowe kategorie klas zależnie od potrzeb.

Klasa Lease jest najbardziej skomplikowana, przechowuje 2 obiekty referencyjne i od jej pól (w szczególności endDate) zależy interpretacja statusu (czy wypożyczenie jest aktywne, czy już sprzęt został zwrócony?) w części serwisowej.

**Opis części serwisowej:**

Klasa Database ma dwa zastosowania: pilnowanie logiki oraz przechowywanie kolekcji obiektów, w szczególności kolekcji obiektów Lease która jest krytyczna dla sprawdzeń wymagań biznesowych.

Zadanie drukowania raportów oddelegowałem do osobnej klasy ReportPrinter celem odseparowania nie-krytycznych dla logiki, ale wciąż ważnych metod serwisowych.

Obiekty klasy Lease są docelowo tworzone tylko za pośrednictwem metody CreateLease w klasie Database. Wtedy klasa Database dokonuje niezbędnych sprawdzeń przed utworzeniem obiektu.

Niestety część logiki opiera się na polach klas, na przykład klasa User przechowuje nie tylko podstawowe informacje, ale i licznik wypożyczeń tego użytkownika. Oddelegowanie tego sprawdzenia do klasy User pozwoliło mi uprościć mechanizm sprawdzeń, dzięki temu reguła biznesowa "dla kazdego typu użytkownika jest n dostępnych wypożyczeń" przechowywana jest tylko w jednym miejscu w kodzie.

Kary za przetrzymanie sprzętu wyliczane są według stawki dziennej podanej przy tworzeniu obiektu Lease i manipulacji datami deadline'u oraz ewentualnego zwrotu.