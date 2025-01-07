from HumanResources import HumanResources
from Developer import Developer
from Manager import Manager
from Designer import Designer

def main():
    # Composite node for Designers
    hr_designer = HumanResources("HR Designer")  # Composite node
    designer1 = Designer(1, "designer1")  # Leaf node
    designer2 = Designer(2, "designer2")  # Leaf node
    hr_designer.add_employee(designer1)
    hr_designer.add_employee(designer2)

    # Composite node for Developers
    hr_developer = HumanResources("HR Developer")  # Composite node
    developer1 = Developer(3, "developer1")  # Leaf node
    developer2 = Developer(4, "developer2")  # Leaf node
    hr_developer.add_employee(developer1)
    hr_developer.add_employee(developer2)

    # Leaf node for Manager
    manager = Manager(5, "manager")

    # Main composite node
    human_resources = HumanResources("HR Main")  # Composite node
    human_resources.add_employee(hr_developer)
    human_resources.add_employee(hr_designer)
    human_resources.add_employee(manager)

    # Display the hierarchical structure
    human_resources.show_info()

if __name__ == "__main__":
    main()