#include <iostream>

// ポインターを使った擬似参照渡し
void sub1(int* p)
{
    (*p)++;
}

// 参照渡し
void sub2(int& p)
{
    p++;
}

int main()
{
    int p1 = 123;
    std::cout << "p1=" << p1 << "\n";
    sub1(&p1);
    std::cout << "p1=" << p1 << "\n";

    int p2 = 123;
    std::cout << "p2=" << p2 << "\n";
    sub2(p2);
    std::cout << "p2=" << p2 << "\n";

    return 0;
}
