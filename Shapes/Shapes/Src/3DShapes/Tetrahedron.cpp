#include "Tetrahedron.h"

Tetrahedron::Tetrahedron(int sideA, int sideB, int sideC, int height, const string & color)
    : Shape(color), sideA(sideA), sideB(sideB), sideC(sideC), height(height) { }

int Tetrahedron::getSideA() const
{
    return sideA;
}

void Tetrahedron::setSideA(int sideA)
{
    this->sideA = sideA;
}

int Tetrahedron::getSideB() const
{
    return sideB;
}

void Tetrahedron::setSideB(int sideB)
{
    this->sideB = sideB;
}

int Tetrahedron::getSideC() const
{
    return sideC;
}

void Tetrahedron::setSideC(int sideC)
{
    this->sideC = sideC;
}

int Tetrahedron::getHeight() const
{
    return height;
}

void Tetrahedron::setHeight(int height)
{
    this->height = height;
}


double Tetrahedron::getVolume() const
{
    double s = (sideA + sideB + sideC) / 2; // semiperimeter
    double areaOfBase = sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    double vol = 1 / 3 * areaOfBase * height;

    return vol;
}