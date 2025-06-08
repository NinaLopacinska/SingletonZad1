Zaimplementuj klasę Logger, która będzie pełniła rolę pojedynczego, globalnego obiektu 
do logowania informacji w aplikacji. Klasa ta powinna być zgodna ze wzorcem Singleton, 
aby zapewnić dostęp do jednej, wspólnej instancji konfiguracji w całej aplikacji. 
Wymagania: 
1. Klasa Logger powinna mieć: 
o Prywatny konstruktor. 
o Statyczną właściwość Instance, zwracającą jedyną instancję klasy. 
o Metody: 
▪ Log(string message), która będzie wyświetlać komunikat na 
konsoli. 
2. Singleton powinien być bezpieczny między wątkami. 
3. Przetestuj działanie Singletona w metodzie Main() poprzez wywołanie logowania z 
różnych miejsc w kodzie.
