// Expresion Lambda
Func<int, int, int> sub = (int a, int b) => a - b;

Func<int, int> some = a => a * 2;

Func<int, int> some2 = a =>
{
    a = a + 1;
    return a * 5;
};


// Como se escribiria si no existieran expresiones lambda
int sub2(int a, int b)
{
    return a - b;
}

// Funcion de orden superior
Some((a,b) => a + b, 5);
void Some(Func<int, int, int> fn, int number)
{
    var result = fn(number, number);
}