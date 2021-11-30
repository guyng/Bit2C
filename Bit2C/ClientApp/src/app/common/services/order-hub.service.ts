import { Injectable } from "@angular/core";
import { HubConnection, HubConnectionBuilder } from "@microsoft/signalr";
import { BehaviorSubject } from "rxjs";
import { OrderType } from "../enums/order-type.enum";

@Injectable({providedIn: 'root'})
export class OrderHubService {

    private hubConnection: HubConnection;

    public reloadOrder: BehaviorSubject<OrderType> = new BehaviorSubject(null)

    public startConnection = () => {
        this.hubConnection = new HubConnectionBuilder()
            //      .configureLogging(1)
            .withUrl('/order', {
            })
            .withAutomaticReconnect()
            .build();

        this.hubConnection
            .start()
            .then(() => console.log('Connection started'))
            .catch(err => console.log('Error while starting connection: ' + err));
    }

    public mainHubListener = () => {
        this.hubConnection.on('reloadOrders', (orderType) => {
            this.reloadOrder.next(orderType);
        })
    }


}