#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

#include "Circle.h"

namespace ShapesTests
{
    TEST_CLASS(CircleTests)
    {
    public:
        TEST_METHOD(CircleWith0RadiusHas0Area)
        {
            Circle c = Circle::Circle(0);
            double area = c.getArea();
            Assert::AreEqual(0, area, DBL_EPSILON);
        }

        TEST_METHOD(CircleWithNegativeRadiusNHas0Area)
        {
            Circle c = Circle::Circle(-1);
            double area = c.getArea();
            Assert::AreEqual(0, area, DBL_EPSILON);
        }

        TEST_METHOD(CircleWithRadius5HasArea78)
        {
            Circle c = Circle::Circle(5);
            double area = c.getArea();
            Assert::AreEqual(78.5398, area, 0.1);
        }

        TEST_METHOD(CircleWithRadius100HasArea31415)
        {
            Circle c = Circle::Circle(100);
            double area = c.getArea();
            Assert::AreEqual(31415.9, area, 0.1);
        }
    };
}