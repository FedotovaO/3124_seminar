 <!-- Задача : 
 Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами -->


Решение
Создаем первый массив со строками. Создаем место под второй массив, аналогичный длинне первого, т.к. не знаем наверняка длинну второго массива.
Создаем первый метод ArraySortString, который отсортирует первый массив по колличеству символов <=3 с помощью счетчика. 
Создаем метод вывода на экран.