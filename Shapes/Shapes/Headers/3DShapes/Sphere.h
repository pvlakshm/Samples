#ifndef SPHERE_H
#define SPHERE_H

#include "Shape.h"

class Sphere : public Shape {
private:
    int radius;

public:
    Sphere(int radius = 1, const string & color = "green");

    int     getRadius() const;
    void    setRadius(int radius);

    double  getVolume() const;
};

#endif