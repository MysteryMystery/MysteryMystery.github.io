terraform {
  cloud {
      organization = "MysteryMystery123"

      workspaces {
        name = "Production"
      }
    }

  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "=3.0.0"
    }
  }
}

provider "azurerm" {
  features {}

  subscription_id = var.subscription_id
 # subscription_id = "8c3134dc-155f-4f19-a31b-7c312286e36f"
}