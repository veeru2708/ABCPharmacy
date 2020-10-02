export interface IMedicine {
    id: number;
    name: string;
    brand:string;
    price: number;
    quantity: number; 

}

class Medicine implements IMedicine
{
    name: string;
    brand: string;
    price: number;
    quantity: number;
    id: number;
    Name: string;
}