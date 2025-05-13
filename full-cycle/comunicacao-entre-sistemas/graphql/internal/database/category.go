package database

import (
	"database/sql"
	"fmt"

	"github.com/google/uuid"
)

type Category struct {
	db *sql.DB
	ID string
	Name string
	Description string
}

func NewCategory(db *sql.DB) *Category {
	return &Category{
		db: db,
	}
}

func (c *Category) Create(name string, description string) (Category, error) {
	id := uuid.New().String()
	_, err := c.db.Exec("INSERT INTO categories (id, name, description) VALUES ($1, $2, $3)", id, name, description)

	if err != nil {
		return Category{}, err
	}

	cat := Category{
		ID: id,
		Name: name,
		Description: description}
	
	return cat, nil
}

func (c *Category) FindAll() ([]Category, error) {
	rows, err := c.db.Query("SELECT id, name, description FROM categories")
	if err != nil {
		return nil, err
	}
	defer rows.Close()

	var categories []Category
	for rows.Next() {
		var cat Category
		if err := rows.Scan(&cat.ID, &cat.Name, &cat.Description); err != nil {
			return nil, err
		}
		categories = append(categories, cat)
	}

	if err := rows.Err(); err != nil {
		return nil, err
	}

	fmt.Printf("Categorias encontradas: %+v\n", categories)

	return categories, nil
}