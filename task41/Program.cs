void Task41() {
    string input = Console.ReadLine();
    int count = 0;
    while (input.ToLower() != "stop") {
        if (int.Parse(input) > 0) count++;
        input = Console.ReadLine();
    }
    Console.WriteLine(count);
}

Task41();