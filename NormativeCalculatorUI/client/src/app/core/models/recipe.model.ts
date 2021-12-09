export class Recipe {
  public id: number;
  public name: string;
  public description: string;
  public recipeCategoryId: number;
  public createdAt: Date;
  public userId: number;
  public isDeleted: boolean;

  constructor(
    id: number,
    name: string,
    description,
    recipeCategoryId: number,
    createdAt: Date,
    userId: number,
    isDeleted: boolean
  ) {
    this.id = id;
    this.name = name;
    this.description = description;
    this.recipeCategoryId = recipeCategoryId;
    this.createdAt = createdAt;
    this.userId = userId;
    this.isDeleted = isDeleted;
  }
}
