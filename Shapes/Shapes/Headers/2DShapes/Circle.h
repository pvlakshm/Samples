#ifndef CIRCLE_H
#define CIRCLE_H

#include "Shape.h"

class Circle : public Shape {
private:
    double radius;

public:
    Circle(double radius = 1.0, const string & color = "green");

    double  getRadius() const;
    void    setRadius(double radius);

    double  getArea() const;
    double  getVolume() const;
};

#endif