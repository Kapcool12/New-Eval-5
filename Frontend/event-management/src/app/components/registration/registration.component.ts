import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { catchError, map } from 'rxjs/operators';
import { of } from 'rxjs';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css'],
  standalone:true,
  imports:[CommonModule,ReactiveFormsModule]
})
export class RegistrationComponent implements OnInit {
  registrationForm!: FormGroup;
  ticketTypes: any[] = [];
  
  private apiUrl = 'https://localhost:7104/api/Registrations';
  private ticketTypesUrl = 'https://localhost:7104/api/TicketTypes';

  constructor(private fb: FormBuilder, private http: HttpClient) { }

  ngOnInit(): void {
    this.registrationForm = this.fb.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      mobileNo: ['', [Validators.required, Validators.pattern('^[0-9]{10,15}$')]],
      age: ['', [Validators.required, Validators.min(1), Validators.max(120)]],
      gender: ['', Validators.required],
      ticketType: ['', Validators.required]
    });

    this.loadTicketTypes();
  }

  loadTicketTypes(): void {
    this.http.get<any[]>(this.ticketTypesUrl).pipe(
      catchError(error => {
        console.error('Error fetching ticket types', error);
        return of([]);
      })
    ).subscribe(data => {
      this.ticketTypes = data;
    });
  }

  onSubmit(): void {
    if (this.registrationForm.valid) {
      this.http.post(this.apiUrl, this.registrationForm.value).pipe(
        catchError(error => {
          console.error('Error submitting registration', error);
          return of(null);
        })
      ).subscribe(response => {
        if (response) {
          alert('Registration successful!');
          this.registrationForm.reset();
        } else {
          alert('Registration failed. Please try again.');
        }
      });
    }
  }
}
