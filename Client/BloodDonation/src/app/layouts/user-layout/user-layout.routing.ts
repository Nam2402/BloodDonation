import { Routes } from '@angular/router';
import { HomePageComponent } from '../../user/home-page/home-page.component';
import { EventComponent } from '../../user/events/event.component';

export const UserLayoutRoutes: Routes = [

    { path: 'home-page',   component: HomePageComponent },
    { path: 'event',   component: EventComponent }
];
