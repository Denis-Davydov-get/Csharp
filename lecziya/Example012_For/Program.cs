//Замена одного символа на другой в функции
string text = "Сегодня мы углубимся в тему и выделим 4 основных группы методов,"
                +"а также будем использовать их на практике. "
                +"И познакомимся с новыми языковыми конструкциями, в частности, циклом.";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty; // пустой контейтейнер
    int lenght = text.Length; //Считаем кол-во знаков в тексте
    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, '|', ' '); 
Console.WriteLine(newText);
