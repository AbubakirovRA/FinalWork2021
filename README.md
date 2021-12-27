# FinalWork2021
## Final work after the first quarter of training at GeekBrains

### Данный репозиторий создан для демонстрации полученных навыков по итогу обучения в течение первой четверти обучения на платформе GeekBrains по курсу "Разработчик".

В ходе решения предложенной задачи выполнено:
1. Создан локальный репозиторий Final Works, в котором для итоговой работы выделена папка 2021.
2. Создан удаленный репозиторий на платформе GitHub.
3. Локальный репозиторий связан с удаленным.
4. Созданы папки BlockDiagrams в котором созданы блок-схемы всех применяемых для решения задачи методов.
5. Все блок схемы выполнены в формате *.drawio.
6. Создана папка Code_C# в которой создан C# проект.
7. В файле Program.cs написан код решения задачи, согласно блок-схем на языке C#.
8. Выполнена декомпозиция задачи на несколько методов, а именно:
* Метод GetArray задает размер массива из случайного диапазона чисел от 10 до 20. После чего заполняет полученный массив случайными числами из диапазона от -99 до 99 включительно.
* Метод EvenIntegers принимает полученный в предыдущем пункте массив. После чего создает новый массив, для хранения четных чисел. Длина данного массива принимается равной длине входящего массива. Далее метод в цикле, количество повторений которого равно количеству элементов входящего массива, проверяет элементы массива на четность. Проверка осуществляется при помощи оценки остатка значения элемента от деления на 2. Если остаток нулевой, значит число четное. Четное число записывается в новый массив EvenIntegers. При этом число-счетчик j, показывающее количество четных чисел в массиве, увеличивается на единицу. По завершению цикла метод передает значение массива EvenInteers и счетчика j.
* Метод PrintArray принимает массив и аргумент. Аргумент показывает сколько элементов массива нужно распечатать в консоль. Если входящий аргумент равен нулю, то массив распечатывается полностью.

https://github.com/AbubakirovRA/FinalWork2021.git


