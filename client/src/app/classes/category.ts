export class Category {
    constructor(name: string, description: string, color: string,id:number) {
        this.name = name;
        this.description = description;
        this.color = color;
        this.id = id;
    }



    id: number;
    name: string;
    description: string;
    color: string;
}
