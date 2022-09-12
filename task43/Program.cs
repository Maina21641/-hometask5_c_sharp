﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Task43(double k1, double b1, double k2, double b2) {
    if (k1 == k2) {
        System.Console.WriteLine("Прямые параллельны");
        return;
    }

    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;

    System.Console.WriteLine($"({x}, {y})");
}

Task43(5, 2, 9, 4);

// y = k1 * x + b1, y = k2 * x + b2
// преобразуем уравнение: 
// k1 * x + b1 = k2 * x + b2
// k1 * x -k2 * x = b2 - b1
// x * (k1-k2) = b2 - b1
// x = (b2 -b1) / (k1 - k2)