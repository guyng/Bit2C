import { OrderType } from "../enums/order-type.enum";

export interface Order{
    price: number;
    amount: number;
    orderType: OrderType;
}