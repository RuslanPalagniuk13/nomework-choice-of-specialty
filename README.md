# Итоговая проверочная работа.

## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Алгоритм решения:
1. Делаем перебор значений из исходного массива;
2. Проверяем каждое значение из массива на соответствие условию: длина строки меньше или равна трем;
3. Если строка удовлетворяет условию кладем значение в новый массив;
4. Повторяем пункты 2 и 3 до тех пор пока не достигнем конца исходного массива;
5. Возвращаем новый заполненый массив как результат.

## Блок-схема алгоритма:
![БлокСхема](BlockDiagram.jpg)

## Программа:
1. Для запуска программы перейдите в папку homewirk и запустите команду через терминал:
*dotnet run (команда)*
2. Далее введите значения через пробел, например:
*введите значения - 2 hello sun 33 world;*
3. Пример вывода программы:
*[2, hello, sun, 33, world] -> [2, sun, 33].*