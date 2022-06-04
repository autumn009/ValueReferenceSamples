#include <iostream>

int main()
{
    char s1[4] = "AUX";
    char* s2 = s1;
    s1[1] = 'C';
    s2[2] = 'E';
    std::cout << s1;
}
