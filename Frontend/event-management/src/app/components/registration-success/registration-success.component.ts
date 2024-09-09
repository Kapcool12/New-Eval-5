import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-registration-success',
  templateUrl: './registration-success.component.html',
  styleUrls: ['./registration-success.component.css'],
  standalone: true,
  imports: [CommonModule]
})
export class RegistrationSuccessComponent implements OnInit {
  registrationId!: string;
  eventName: string = '';
  userEmail: string = '';
  totalAmount: number = 0;
  registrationDetails: any = {};  // Store registration details

  constructor(
    private route: ActivatedRoute,
    private http: HttpClient,
    private router: Router
  ) {}

  ngOnInit(): void {
    // Get the registrationId from the route parameters
    this.registrationId = this.route.snapshot.paramMap.get('registrationId') || '';

    if (this.registrationId) {
      // Fetch registration details using the registration ID
      this.getRegistrationDetails(this.registrationId);
    }
  }

  // Fetch registration details using the registration ID
  getRegistrationDetails(registrationId: string): void {
    this.http.get<any>(`https://localhost:7104/api/Registrations/${registrationId}`)
      .subscribe({
        next: (registration) => {
          console.log('Registration Details:', registration);
          this.registrationDetails = registration;

          // Assuming registration contains eventId, userEmail, and totalAmount fields
          this.userEmail = registration.userEmail;
          const { eventId, totalAmount } = registration;
          this.totalAmount = totalAmount;

          if (eventId) {
            // Fetch event details using the event ID
            this.getEventDetails(eventId);
          }
        },
        error: (error) => {
          console.error('Error fetching registration details:', error);
        }
      });
  }

  // Fetch event details using the event ID
  getEventDetails(eventId: string): void {
    this.http.get<any>(`https://localhost:7104/api/Events/${eventId}`)
      .subscribe({
        next: (event) => {
          console.log('Event Details:', event);
          this.eventName = event.name;  // Assuming event has a name field
        },
        error: (error) => {
          console.error('Error fetching event details:', error);
        }
      });
  }

  // Method to navigate back to home page
  navigateToHome(): void {
    this.router.navigate(['/event-selection']);  // Redirect to the homepage or any other route
  }
}
