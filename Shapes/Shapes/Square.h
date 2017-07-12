#include "Shape.h"

class Square : public Shape {
private:
    int side;

public:
    Square(int side = 1, const string & color = "black");
    int     getSide() const;
    void    setSide(int side);
    double  getArea() const;
};