# puzzle_cube_2d

## Cel
Celem aplikacji jest stworzenie gry logicznej typu puzzle, w której użytkownik układa elementy w odpowiednim porządku.

## Zasada działania
Gra wyświetla planszę z klockami/kostkami. Użytkownik może przesuwać elementy, aby dopasować je w odpowiednie miejsce.

## Interakcja z użytkownikiem
Użytkownik steruje elementami myszką lub przyciskami.  
Aplikacja sprawdza poprawność ułożenia i w przypadku sukcesu wyświetla komunikat o ukończeniu układanki.

# versje

## ver. 0.00
pierwsza wersja projektu. zawiera pustą scenę unity. brak jeszcze funkcjonalności.

## ver 0.01
dodane menu 

## ver 0.10
dodane zasady clean code:

1. Meaningful Names
2. KISS (Keep It Simple, Stupid)
3. DRY (Don’t Repeat Yourself)
4. Consistent Naming Conventions
5. Useful Comments Only

dodana lista levlów 

## ver 0.11
edytowane i stylizowane menu 
start robienia level 1

## ver 0.12
dodany 1 level 

## ver 0.4 
zrobione wszysztkie 6 level

## ver 0.5 
dodany przycisk pomocniczy do rozwiazania puzzla

## ver 0.6 Testowanie aplikacji

# 1. Wybór metod testowania

Do testowania aplikacji (gry wykonanej w Unity) wybrano dwie metody:

- Testy funkcjonalne – sprawdzające poprawność działania elementów gry  
- Testy użyteczności (UX) – sprawdzające wygodę i czytelność dla użytkownika  

 

# 2. Plan testów

**Cel testów:**  
Sprawdzenie działania gry po jej opublikowaniu oraz ocena komfortu użytkownika.

**Zakres testów:**
- działanie interfejsu użytkownika  
- widoczność przycisków  
- rozmiar i czytelność poziomów  
- ogólna rozgrywka  

**Środowisko testowe:**
- komputer  
- przeglądarka internetowa  
- gra opublikowana z Unity  



# 3. Implementacja testów

Przygotowano scenariusze testowe:

**Test 1 – interfejs użytkownika**
- sprawdzenie czy wszystkie przyciski są widoczne  
- sprawdzenie działania przycisków  

**Test 2 – rozgrywka**
- sprawdzenie wielkości poziomów  
- ocena wygody poruszania się po planszy  


## 4. Wykonanie testów

Testy zostały wykonane na opublikowanej wersji gry.

---

## 5. Wyniki testów

Podczas testowania gry stworzonej w Unity wykryto następujące błędy:

- Przycisk pomocy dla gracza nie wyświetla się po opublikowaniu gry  
- Poziomy są zbyt duże, co utrudnia rozgrywkę i orientację w grze  

Błędy zostały zapisane do dalszej analizy i poprawy.



## 6. Dokumentacja i wersjonowanie

Po wykonaniu testów:
- zapisano wyniki testów w dokumentacji  
- oznaczono wersję gry jako 0.6


## 7. Weryfikacja aplikacji po testach

Na podstawie testów zaplanowano następujące poprawki:

- naprawa problemu z wyświetlaniem przycisku pomocy  
- zmniejszenie rozmiaru poziomów  
- ponowne testowanie po wprowadzeniu zmian  

Ze względu na brak czasu poprawki nie zostały jeszcze wykonane, ale zostały zaplanowane do kolejnej wersji projektu.
