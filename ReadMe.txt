TipoviOperatori
===============

PromjenaImenika
---------------

Primjer kako se promijeni podrazumijevani imenik nakon kreiranja projekta
u svojstvima projekta (Properties)

Ilustracija kako se istoimeni objekti iz razli�itih imenika mogu dohva�ati.


Dokumentacijski komentari
-------------------------
Primjer dokumentacijskih komentara - opis funkcije Kvadrat


Main
----
Unutar klase smije biti samo jedan Main metoda (bez obzira �to se metode u C# 
mogu preoptere�ivati).

Unutar izvedbenog (.EXE) modula mo�e biti vi�e Main metoda u razli�itim 
klasama, ali tada prevoditelju treba navesti koja klasa �e biti "po�etna", tj. 
od koje Main metode treba program pokrenuti.


Identifikatori
--------------
Primjer kako se neke klju�ne i rezervirane rije�i mogu koristiti za 
identifikatore.
- string je klju�na rije� (keyword);
- get je kontekstna klju�na rije� (contextual keyword), tj. ima posebno 
  zna�enje samo na odre�enim mjestima;
- Main je rezervirana rije� (reserved word).


UgradjeniTipoviIL
-----------------
Primjer kojim se mo�e pokazati da svi ugradjeni tipovi osim decimal imaju 
izravne ekvivalente u IL-u.
Izgenerirani kod treba pogledati s ILDASM (IL disassemblerom).


UgradjeniTipoviInicijalizacija
------------------------------
Primjer koji pokazuje kako se ugradjeni tipovi mogu inicijalizirati samo 
operatorom pridru�ivanja ili podrazumijevanim konstruktorom.


Nulabilni
---------

Primjer kori�tenja i inicijalizacije nulabilnih tipova.


Deklaracija var
---------------

Varijabli koja je deklarirana klju�nom rije�i var �e prevoditelj automatski
odrediti tip.


OperatorIs
----------
Operator is provjerava je li objekt s lijeve strane kompatibilan s tipom na 
desnoj strani (je li instanca tog tipa ili nekog izvedenog tipa)


OperatorAs
----------
Operator as omogu�ava sigurnu pretvorbu: ako se pretvorba ne mo�e provesti
vrijednost objekta �e biti null. Kod operatora pretvorbe (cast) nepravilna
pretvorba �e baciti InvalidCastException.


OperatorSizeof
--------------
Operator sizeof vra�a veli�inu memorijskog prostora kojeg tip zauzima. Mogu�e 
je tra�iti samo za vrijednosne tipove!


OperatorTypeof
--------------
Operator typeof vra�a kao rezultat objekt tipa Type koji sadr�i sve informacije
o doti�nom tipu.
