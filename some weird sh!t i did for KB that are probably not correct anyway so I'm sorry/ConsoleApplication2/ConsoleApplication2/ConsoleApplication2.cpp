#include <iostream>
#include <vector>
using namespace std;

int carsAmount;
double avg;

class car {
	int ownerId;
	string carLicensePlate;
	string carManufacturer;
	int productionYear;

public:
	car(int ownerId, string carLicensePlate, string carManufacturer, int productionYear) {
		ownerId = ownerId;
		carLicensePlate = carLicensePlate;
		carManufacturer = carManufacturer;
		productionYear = productionYear;
	}
};

vector <string> manufacturers;



