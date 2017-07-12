#include "Shape.h"

class Tetrahedron : public Shape {
private:
    int sideA;
    int sideB;
    int sideC;
    int height;

public:
    Tetrahedron(int sideA = 1, int sideB = 1, int sideC = 1, int height = 1, const string & color = "black");
    int     getSideA() const;
    void    setSideA(int sideA);
    int     getSideB() const;
    void    setSideB(int sideB);
    int     getSideC() const;
    void    setSideC(int sideC);

    int     getHeight() const;
    void    setHeight(int height);


    double  getVolume() const;
};