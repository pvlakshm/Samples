#include "Shape.h"

class Cuboid : public Shape
{
private:
    int length;
    int width;
    int height;

public:
    Cuboid(int length = 1, int width = 1, int height = 1, const string & color = "green");

    int     getLength() const;
    void    setLength(int length);

    int     getWidth() const;
    void    setWidth(int width);

    int     getHeight() const;
    void    setHeight(int height);

    double  getVolume() const;
};