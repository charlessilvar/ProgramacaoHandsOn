//ECMAScript2015 module import statement. It imports the Component decorator from the @angular/core package, which is essential for defining an Angular component.
import { Component } from "@angular/core"; 

// This is a decorator that marks the class as an Angular component. It can take various metadata properties to define the component's behavior and appearance.
@Component({
    // This defines the custom HTML tag that will be used to represent this component in the template.
    selector: "app-meu-primeiro", 
    // This is the inline template for the component, which will render an H1 heading when the component is used in the application.
    template: `<h1>Meu Primeiro Componente Angular</h1>`, 
}) 
// exports the class so that it can be imported and used in other parts of the application. The class name is MeuPrimeiroComponent,
// which follows the convention of using PascalCase for class names in TypeS
// This is a simple TypeScript class representing a component in an Angular application.
export class MeuPrimeiroComponent { 
    constructor() {
        // This will log a message to the console when an instance of this component is created.
        console.log("MeuPrimeiroComponent has been created!"); 
    }

}