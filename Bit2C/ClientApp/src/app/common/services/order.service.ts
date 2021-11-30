import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { OrderType } from "../enums/order-type.enum";
import { Order } from "../models/order.model";

@Injectable({providedIn: "root"})
export class OrderService{
    constructor(private httpClient: HttpClient){

    }

    public getOrders(orderType: OrderType = OrderType.BUY): Observable<Order[]>{
        return this.httpClient.get<Order[]>('api/Order?orderType=' + orderType);
    }

    public addOrder(order: Order){
        return this.httpClient.post('api/Order',order);
    }
}