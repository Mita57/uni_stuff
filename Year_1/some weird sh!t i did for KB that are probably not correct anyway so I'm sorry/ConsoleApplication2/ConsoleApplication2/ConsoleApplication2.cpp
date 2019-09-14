#include <iostream>
#include <math.h>
#include <vector>
using namespace std;

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

class manufacturer {
	string name;
	vector <int> years;
	int amount;
	int avgAge;

public: int countAvgAge() {
	int sum = 0;
	for (int i = 0; i < years.size; i++) {
		sum += years[i];
	}
	double avgAgeDouble = (sum / amount);
	avgAge = round(avgAgeDouble);
	return avgAge;
}
public:
	manufacturer(string name) {
		name = name;
		vector <int> years;
	}
};