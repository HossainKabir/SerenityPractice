namespace PracticeProject.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'PracticeProject.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
