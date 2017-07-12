#include "Shape.h"

class Circle : public Shape {
private:
    int radius;

public:
    Circle(int radius = 1, const string & color = "black");

    int     getRadius() const;
    void    setRadius(int radius);

    double  getArea() const;
    double  getVolume() const;
};
