
export class Borrower {
    constructor(id: number, tz: string, ageCategory: number,
        firstName: string, lastName: string, phoneNumber: string, email: string) {
        this.id = id;
        this.tz = tz;
        this.ageCategory = ageCategory;
        this.firstName = firstName;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }
    id: number;
    tz: string;
    ageCategory: number;
    firstName: string;
    lastName: string;
    phoneNumber: string;
    email: string;
}
