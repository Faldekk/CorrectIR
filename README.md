# Infinite Runner — lekcja 6

Otwórz ten folder w Unity Hub i uruchom projekt w Unity **6000.6.7f1** (Unity 6.6). Otwórz scenę `Assets/Scenes/SampleScene.unity` i naciśnij **Play**.

- Kliknij lewym przyciskiem myszy, aby skoczyć. Kliknij ponownie, aby wykonać drugi skok.
- Przytrzymaj lewy przycisk podczas opadania, aby działała siła unoszenia.
- Dwa segmenty podłogi o szerokości 16 jednostek przesuwają się w lewo o 0,2 jednostki na krok fizyki. Po przekroczeniu progu tylny segment przeskakuje o 32 jednostki.
- Wynik rośnie o prędkość przewijania na każdy krok fizyki. `ScoreText` na Canvasie wyświetla go w TextMeshPro.

Ustawienia z archiwum po lekcji 6 obejmują siłę skoku 20, siłę unoszenia 2000, mnożnik grawitacji 6 i warstwę `Ground` (8). Oryginalna logika sprawdza możliwość resetowania skoków na podłodze z odstępem jednej sekundy.

Projekt używa TextMeshPro z pakietu Unity UI oraz zasobów TMP dołączonych do `Assets`. Ustawienie **Active Input Handling** ma wartość **Both**, dzięki czemu działa wejście myszy i moduł EventSystem z archiwum. Kwadratowy sprite jest częścią projektu.
