// Emilio Vega de Llergo Vargas
// 00549955

#include <iostream>
#include <string>

using namespace std;

int main()
{
    string nombre;
    int n1, n2;

    cout << "¿Cual es tu nombre?" << endl;
    cin >> nombre;

    cout << "Hola " << nombre << " escribe dos valores enteros: " << endl;
    cin >> n1;
    cin >> n2;

    cout << "La suma es: " << (n1 + n2) << endl;

    return 0;
}