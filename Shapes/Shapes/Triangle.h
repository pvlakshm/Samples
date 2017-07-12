#include "Shape.h"

class Triangle : public Shape {
private:
    int base;
    int height;

public:
    Triangle(int base = 1, int height = 1, const string & color = "black");
    int     getBase() const;
    void    setBase(int base);
    int     getHeight() const;
    void    setHeight(int height);
    double  getArea() const;
};