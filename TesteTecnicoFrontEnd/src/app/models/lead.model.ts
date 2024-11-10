import { EnumStatusLead } from "./enums/enum-status-lead";

export class Lead {
  id: number;
  contactFirstName: string;
  contactFullName: string;
  contactPhoneNumber: string;
  contactEmail: string;
  dateCreated: Date;
  suburb: string;
  category: string;
  description: string;
  price: number;
  status: EnumStatusLead;

  constructor(
    id: number,
    contactFirstName: string,
    contactFullName: string,
    contactPhoneNumber: string,
    contactEmail: string,
    dateCreated: Date,
    suburb: string,
    category: string,
    description: string,
    price: number,
    status: EnumStatusLead
  ) {
    this.id = id;
    this.contactFirstName = contactFirstName;
    this.contactFullName = contactFullName;
    this.contactPhoneNumber = contactPhoneNumber;
    this.contactEmail = contactEmail;
    this.dateCreated = dateCreated;
    this.suburb = suburb;
    this.category = category;
    this.description = description;
    this.price = price;
    this.status = status;
  }
}
