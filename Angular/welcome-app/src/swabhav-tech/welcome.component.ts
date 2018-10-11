import { Component } from '@angular/core';

@Component({
    templateUrl: './welcome.component.html',
    selector: 'st-welcome'
})
export class WelcomeComponent {
    message: string;
    inputtext: string;

    constructor() {
        this.message = 'This is Welcome Component';
        this.inputtext = 'hello Button';
    }
}
